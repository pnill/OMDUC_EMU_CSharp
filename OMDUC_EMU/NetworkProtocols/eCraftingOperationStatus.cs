using System;

namespace NetworkProtocols
{
	// Token: 0x020004CF RID: 1231
	public enum eCraftingOperationStatus
	{
		// Token: 0x040019AB RID: 6571
		Failure,
		// Token: 0x040019AC RID: 6572
		Success,
		// Token: 0x040019AD RID: 6573
		InvalidRecipe,
		// Token: 0x040019AE RID: 6574
		NotEnoughComponents,
		// Token: 0x040019AF RID: 6575
		NotEnoughSoftCurrency,
		// Token: 0x040019B0 RID: 6576
		NotEnoughHardCurrency,
		// Token: 0x040019B1 RID: 6577
		RecipeNotUnlocked,
		// Token: 0x040019B2 RID: 6578
		ItemAlreadyCrafted
	}
}
