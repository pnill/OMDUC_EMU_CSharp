using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace NetworkProtocols
{
	// Token: 0x020006CE RID: 1742
	public class NetLockFreeQueue<TQueueItem> : IDisposable
	{
		// Token: 0x06003E76 RID: 15990 RVA: 0x00116B14 File Offset: 0x00114D14
		public NetLockFreeQueue()
		{
			NetLockFreeQueue<TQueueItem>.node_t ptr = new NetLockFreeQueue<TQueueItem>.node_t();
			this.Head.ptr = (this.Tail.ptr = ptr);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00116B5C File Offset: 0x00114D5C
		public NetLockFreeQueue(bool blocking)
		{
			NetLockFreeQueue<TQueueItem>.node_t ptr = new NetLockFreeQueue<TQueueItem>.node_t();
			this.Head.ptr = (this.Tail.ptr = ptr);
			this._isBlocking = blocking;
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0002323C File Offset: 0x0002143C
		public long Count
		{
			get
			{
				return Interlocked.Read(ref this._count);
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06003E79 RID: 15993 RVA: 0x00023249 File Offset: 0x00021449
		public bool IsBlocking
		{
			get
			{
				return this._isBlocking;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x00023251 File Offset: 0x00021451
		public bool IsShutdown
		{
			get
			{
				return this._isShutdown;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x0002325B File Offset: 0x0002145B
		public ManualResetEvent EmptyEvent
		{
			get
			{
				return this._emptyEvent;
			}
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00023263 File Offset: 0x00021463
		public void Shutdown()
		{
			if (this._isShutdown)
			{
				return;
			}
			this._isShutdown = true;
			this._emptyEvent.Set();
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00023288 File Offset: 0x00021488
		private static bool CAS(ref NetLockFreeQueue<TQueueItem>.pointer_t destination, NetLockFreeQueue<TQueueItem>.pointer_t compared, NetLockFreeQueue<TQueueItem>.pointer_t exchange)
		{
			if (compared.ptr == Interlocked.CompareExchange<NetLockFreeQueue<TQueueItem>.node_t>(ref destination.ptr, exchange.ptr, compared.ptr))
			{
				Interlocked.Exchange(ref destination.count, exchange.count);
				return true;
			}
			return false;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00116BAC File Offset: 0x00114DAC
		private bool InternalDequeue(ref TQueueItem t)
		{
			bool flag = true;
			while (flag)
			{
				NetLockFreeQueue<TQueueItem>.pointer_t head = this.Head;
				NetLockFreeQueue<TQueueItem>.pointer_t tail = this.Tail;
				NetLockFreeQueue<TQueueItem>.pointer_t next = head.ptr.next;
				if (head.count == this.Head.count && head.ptr == this.Head.ptr)
				{
					if (head.ptr == tail.ptr)
					{
						if (next.ptr == null)
						{
							return false;
						}
						NetLockFreeQueue<TQueueItem>.CAS(ref this.Tail, tail, new NetLockFreeQueue<TQueueItem>.pointer_t(next.ptr, tail.count + 1L));
					}
					else
					{
						t = next.ptr.value;
						if (NetLockFreeQueue<TQueueItem>.CAS(ref this.Head, head, new NetLockFreeQueue<TQueueItem>.pointer_t(next.ptr, head.count + 1L)))
						{
							flag = false;
							Interlocked.Decrement(ref this._count);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000232C5 File Offset: 0x000214C5
		public void PulseEvent()
		{
			if (this._isBlocking)
			{
				this._emptyEvent.Set();
				this._emptyEvent.Reset();
			}
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00116CA0 File Offset: 0x00114EA0
		public void Clear()
		{
			NetLockFreeQueue<TQueueItem>.node_t ptr = new NetLockFreeQueue<TQueueItem>.node_t();
			this.Head.ptr = (this.Tail.ptr = ptr);
			Interlocked.Exchange(ref this._count, 0L);
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00116CDC File Offset: 0x00114EDC
		[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#")]
		public bool Dequeue(ref TQueueItem queueItem)
		{
			bool flag = false;
			if (this._isShutdown)
			{
				return false;
			}
			this._emptyEvent.Reset();
			if (Interlocked.Read(ref this._count) > 0L)
			{
				flag = this.InternalDequeue(ref queueItem);
			}
			if (!this._isBlocking || flag)
			{
				return flag;
			}
			this._emptyEvent.WaitOne();
			if (this._isShutdown)
			{
				return false;
			}
			if (Interlocked.Read(ref this._count) > 0L)
			{
				flag = this.InternalDequeue(ref queueItem);
			}
			return flag;
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00116D70 File Offset: 0x00114F70
		public void Enqueue(TQueueItem queueItem)
		{
			if (this._isShutdown)
			{
				return;
			}
			NetLockFreeQueue<TQueueItem>.node_t node_t = new NetLockFreeQueue<TQueueItem>.node_t();
			node_t.value = queueItem;
			bool flag = true;
			while (flag)
			{
				NetLockFreeQueue<TQueueItem>.pointer_t tail = this.Tail;
				NetLockFreeQueue<TQueueItem>.pointer_t next = tail.ptr.next;
				if (tail.count == this.Tail.count && tail.ptr == this.Tail.ptr)
				{
					if (next.ptr == null)
					{
						if (NetLockFreeQueue<TQueueItem>.CAS(ref tail.ptr.next, next, new NetLockFreeQueue<TQueueItem>.pointer_t(node_t, next.count + 1L)))
						{
							Interlocked.Increment(ref this._count);
							flag = false;
							if (this._isBlocking)
							{
								this._emptyEvent.Set();
							}
						}
					}
					else
					{
						NetLockFreeQueue<TQueueItem>.CAS(ref this.Tail, tail, new NetLockFreeQueue<TQueueItem>.pointer_t(next.ptr, tail.count + 1L));
					}
				}
			}
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000232EA File Offset: 0x000214EA
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Shutdown();
			}
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000232F8 File Offset: 0x000214F8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040020C1 RID: 8385
		private long _count;

		// Token: 0x040020C2 RID: 8386
		private NetLockFreeQueue<TQueueItem>.pointer_t Head;

		// Token: 0x040020C3 RID: 8387
		private NetLockFreeQueue<TQueueItem>.pointer_t Tail;

		// Token: 0x040020C4 RID: 8388
		private bool _isBlocking = true;

		// Token: 0x040020C5 RID: 8389
		private volatile bool _isShutdown;

		// Token: 0x040020C6 RID: 8390
		private ManualResetEvent _emptyEvent = new ManualResetEvent(false);

		// Token: 0x020006CF RID: 1743
		private class node_t
		{
			// Token: 0x040020C7 RID: 8391
			public TQueueItem value;

			// Token: 0x040020C8 RID: 8392
			public NetLockFreeQueue<TQueueItem>.pointer_t next;
		}

		// Token: 0x020006D0 RID: 1744
		private struct pointer_t
		{
			// Token: 0x06003E86 RID: 16006 RVA: 0x00023307 File Offset: 0x00021507
			public pointer_t(NetLockFreeQueue<TQueueItem>.pointer_t p)
			{
				this.ptr = p.ptr;
				this.count = p.count;
			}

			// Token: 0x06003E87 RID: 16007 RVA: 0x00023323 File Offset: 0x00021523
			public pointer_t(NetLockFreeQueue<TQueueItem>.node_t node, long c)
			{
				this.ptr = node;
				this.count = c;
			}

			// Token: 0x040020C9 RID: 8393
			public long count;

			// Token: 0x040020CA RID: 8394
			public NetLockFreeQueue<TQueueItem>.node_t ptr;
		}
	}
}
