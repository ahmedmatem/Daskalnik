namespace Core.Claims
{
    public static class CustomUserClaims
    {
        public static KeyValuePair<string, string> ActiveClaim =
            new KeyValuePair<string, string>("active", "activated");
    }
}
