# OMDUC_EMU_CSharp
Orcs Must Die Unchained - DashBoard server emulator written in C#

This is far from being completed it currently just processes some login data and will get you to a loading screen, still attepmting to reverse to determine exactly what's going wrong and why it's getting stuck at the loading screen.

Makes use of the original packet serialziation code from the game itself which is why C# was used, this was originally being written in python but due to complexity was migrated to C#.

You'll need to replace the RSA keypair in both the game's Assembly-CSharp.dll and this code in order for the initial assymetric keyexchange to work, otherwise you could just disable crypto in the client itself it's enabled by default.