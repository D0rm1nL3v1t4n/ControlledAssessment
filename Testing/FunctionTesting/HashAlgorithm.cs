namespace Testing
{
    public class HashAlgorithm
    {
        public static void TestHashAlgorithm()
        {
            string hash1 = WelshWanderers.Functions.HashAlgorithm.HashPassword("Password1!");
            string hash2 = WelshWanderers.Functions.HashAlgorithm.HashPassword("Password1!");
            string hash3 = WelshWanderers.Functions.HashAlgorithm.HashPassword("ABCDE123!£$");
            if (hash1 != hash2 && hash1 != "Password1!" && hash3 != "ABCDE123!£$" && hash1.Length == hash2.Length && hash1.Length == hash2.Length
                && WelshWanderers.Functions.HashAlgorithm.CheckHashes(hash1, "Password1!") && WelshWanderers.Functions.HashAlgorithm.CheckHashes(hash2, "Password1!") && WelshWanderers.Functions.HashAlgorithm.CheckHashes(hash3, "ABCDE123!£$"))
                TestResult.TestPass();
            else
                TestResult.TestFail("Hash algorithm");
        }
    }
}
