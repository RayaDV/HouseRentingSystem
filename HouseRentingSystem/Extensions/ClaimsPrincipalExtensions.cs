namespace System.Security.Claims
{
    public static class ClaimsPrincipalExtensions  // if a class exstends, then it is static
    {
        public static string Id (this ClaimsPrincipal user) 
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
