using System;

namespace NetworkProtocols
{
	// Token: 0x020004C4 RID: 1220
	public enum ePriceCurrencyType
	{
		// Token: 0x040018AB RID: 6315
		None,
		// Token: 0x040018AC RID: 6316
		Gold,
		// Token: 0x040018AD RID: 6317
		Skulls,
		// Token: 0x040018AE RID: 6318
		USD,
		// Token: 0x040018AF RID: 6319
		EUR,
		// Token: 0x040018B0 RID: 6320
		GBP,
		// Token: 0x040018B1 RID: 6321
		RUB,
		// Token: 0x040018B2 RID: 6322
		CAD,
		// Token: 0x040018B3 RID: 6323
		JPY,
		// Token: 0x040018B4 RID: 6324
		IDR,
		// Token: 0x040018B5 RID: 6325
		NZD,
		// Token: 0x040018B6 RID: 6326
		NOK,
		// Token: 0x040018B7 RID: 6327
		PHP,
		// Token: 0x040018B8 RID: 6328
		SGD,
		// Token: 0x040018B9 RID: 6329
		THB,
		// Token: 0x040018BA RID: 6330
		TRY,
		// Token: 0x040018BB RID: 6331
		MYR,
		// Token: 0x040018BC RID: 6332
		MXN,
		// Token: 0x040018BD RID: 6333
		BRL,
		// Token: 0x040018BE RID: 6334
		KRW,
		// Token: 0x040018BF RID: 6335
		CNY,
		// Token: 0x040018C0 RID: 6336
		TWD,
		// Token: 0x040018C1 RID: 6337
		AUG,
		// Token: 0x040018C2 RID: 6338
		UAH,
		// Token: 0x040018C3 RID: 6339
		CHF,
		// Token: 0x040018C4 RID: 6340
		INR,
		// Token: 0x040018C5 RID: 6341
		CLP,
		// Token: 0x040018C6 RID: 6342
		PEN,
		// Token: 0x040018C7 RID: 6343
		COP,
		// Token: 0x040018C8 RID: 6344
		ZAR,
		// Token: 0x040018C9 RID: 6345
		HKD,
		// Token: 0x040018CA RID: 6346
		SAR,
		// Token: 0x040018CB RID: 6347
		AED,
		// Token: 0x040018CC RID: 6348
		AFN = 37,
		// Token: 0x040018CD RID: 6349
		ALL,
		// Token: 0x040018CE RID: 6350
		DZD,
		// Token: 0x040018CF RID: 6351
		AOA,
		// Token: 0x040018D0 RID: 6352
		XCD,
		// Token: 0x040018D1 RID: 6353
		ARS,
		// Token: 0x040018D2 RID: 6354
		AMD,
		// Token: 0x040018D3 RID: 6355
		AWG,
		// Token: 0x040018D4 RID: 6356
		AUD,
		// Token: 0x040018D5 RID: 6357
		AZN,
		// Token: 0x040018D6 RID: 6358
		BSD,
		// Token: 0x040018D7 RID: 6359
		BHD,
		// Token: 0x040018D8 RID: 6360
		BDT,
		// Token: 0x040018D9 RID: 6361
		BBD,
		// Token: 0x040018DA RID: 6362
		BYR,
		// Token: 0x040018DB RID: 6363
		BZD,
		// Token: 0x040018DC RID: 6364
		XOF,
		// Token: 0x040018DD RID: 6365
		BMD,
		// Token: 0x040018DE RID: 6366
		BOB,
		// Token: 0x040018DF RID: 6367
		BAM,
		// Token: 0x040018E0 RID: 6368
		BWP,
		// Token: 0x040018E1 RID: 6369
		BND,
		// Token: 0x040018E2 RID: 6370
		BGN,
		// Token: 0x040018E3 RID: 6371
		BIF,
		// Token: 0x040018E4 RID: 6372
		KHR,
		// Token: 0x040018E5 RID: 6373
		XAF,
		// Token: 0x040018E6 RID: 6374
		CVE,
		// Token: 0x040018E7 RID: 6375
		KYD,
		// Token: 0x040018E8 RID: 6376
		KMF,
		// Token: 0x040018E9 RID: 6377
		CRC,
		// Token: 0x040018EA RID: 6378
		HRK,
		// Token: 0x040018EB RID: 6379
		CUP,
		// Token: 0x040018EC RID: 6380
		ANG,
		// Token: 0x040018ED RID: 6381
		DKK,
		// Token: 0x040018EE RID: 6382
		DJF,
		// Token: 0x040018EF RID: 6383
		DOP,
		// Token: 0x040018F0 RID: 6384
		EGP,
		// Token: 0x040018F1 RID: 6385
		ERN,
		// Token: 0x040018F2 RID: 6386
		ETB,
		// Token: 0x040018F3 RID: 6387
		FKP,
		// Token: 0x040018F4 RID: 6388
		FJD,
		// Token: 0x040018F5 RID: 6389
		XPF,
		// Token: 0x040018F6 RID: 6390
		GMD,
		// Token: 0x040018F7 RID: 6391
		GEL,
		// Token: 0x040018F8 RID: 6392
		GHS,
		// Token: 0x040018F9 RID: 6393
		GIP,
		// Token: 0x040018FA RID: 6394
		GTQ,
		// Token: 0x040018FB RID: 6395
		GNF,
		// Token: 0x040018FC RID: 6396
		GYD,
		// Token: 0x040018FD RID: 6397
		HNL,
		// Token: 0x040018FE RID: 6398
		HUF,
		// Token: 0x040018FF RID: 6399
		ISK,
		// Token: 0x04001900 RID: 6400
		IRR,
		// Token: 0x04001901 RID: 6401
		IQD,
		// Token: 0x04001902 RID: 6402
		ILS,
		// Token: 0x04001903 RID: 6403
		JMD,
		// Token: 0x04001904 RID: 6404
		JOD,
		// Token: 0x04001905 RID: 6405
		KZT,
		// Token: 0x04001906 RID: 6406
		KES,
		// Token: 0x04001907 RID: 6407
		KWD,
		// Token: 0x04001908 RID: 6408
		KGS,
		// Token: 0x04001909 RID: 6409
		LAK,
		// Token: 0x0400190A RID: 6410
		GameCode,
		// Token: 0x0400190B RID: 6411
		LRD,
		// Token: 0x0400190C RID: 6412
		LYD,
		// Token: 0x0400190D RID: 6413
		MOP,
		// Token: 0x0400190E RID: 6414
		MKD,
		// Token: 0x0400190F RID: 6415
		MGA,
		// Token: 0x04001910 RID: 6416
		MWK,
		// Token: 0x04001911 RID: 6417
		MVR,
		// Token: 0x04001912 RID: 6418
		MRO,
		// Token: 0x04001913 RID: 6419
		MUR,
		// Token: 0x04001914 RID: 6420
		MDL,
		// Token: 0x04001915 RID: 6421
		MNT,
		// Token: 0x04001916 RID: 6422
		MAD,
		// Token: 0x04001917 RID: 6423
		MZN,
		// Token: 0x04001918 RID: 6424
		MMK,
		// Token: 0x04001919 RID: 6425
		NPR,
		// Token: 0x0400191A RID: 6426
		NIO,
		// Token: 0x0400191B RID: 6427
		NGN,
		// Token: 0x0400191C RID: 6428
		KPW,
		// Token: 0x0400191D RID: 6429
		OMR,
		// Token: 0x0400191E RID: 6430
		PKR,
		// Token: 0x0400191F RID: 6431
		PGK,
		// Token: 0x04001920 RID: 6432
		PYG,
		// Token: 0x04001921 RID: 6433
		PLN,
		// Token: 0x04001922 RID: 6434
		QAR,
		// Token: 0x04001923 RID: 6435
		RON,
		// Token: 0x04001924 RID: 6436
		RWF,
		// Token: 0x04001925 RID: 6437
		WST,
		// Token: 0x04001926 RID: 6438
		RSD,
		// Token: 0x04001927 RID: 6439
		SCR,
		// Token: 0x04001928 RID: 6440
		SLL,
		// Token: 0x04001929 RID: 6441
		SBD,
		// Token: 0x0400192A RID: 6442
		SOS,
		// Token: 0x0400192B RID: 6443
		SSP,
		// Token: 0x0400192C RID: 6444
		LKR,
		// Token: 0x0400192D RID: 6445
		SHP,
		// Token: 0x0400192E RID: 6446
		SDG,
		// Token: 0x0400192F RID: 6447
		SRD,
		// Token: 0x04001930 RID: 6448
		SZL,
		// Token: 0x04001931 RID: 6449
		SEK,
		// Token: 0x04001932 RID: 6450
		SYP,
		// Token: 0x04001933 RID: 6451
		STD,
		// Token: 0x04001934 RID: 6452
		TJS,
		// Token: 0x04001935 RID: 6453
		TZS,
		// Token: 0x04001936 RID: 6454
		TOP,
		// Token: 0x04001937 RID: 6455
		TTD,
		// Token: 0x04001938 RID: 6456
		TND,
		// Token: 0x04001939 RID: 6457
		TMT,
		// Token: 0x0400193A RID: 6458
		UGX,
		// Token: 0x0400193B RID: 6459
		UYU,
		// Token: 0x0400193C RID: 6460
		UZS,
		// Token: 0x0400193D RID: 6461
		VUV,
		// Token: 0x0400193E RID: 6462
		VEF,
		// Token: 0x0400193F RID: 6463
		VND,
		// Token: 0x04001940 RID: 6464
		YER,
		// Token: 0x04001941 RID: 6465
		ZMW,
		// Token: 0x04001942 RID: 6466
		ZWL,
		// Token: 0x04001943 RID: 6467
		LBP,
		// Token: 0x04001944 RID: 6468
		CZK,
		// Token: 0x04001945 RID: 6469
		Gibs
	}
}
