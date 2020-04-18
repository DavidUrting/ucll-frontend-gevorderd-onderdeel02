using System;

namespace Oefening1.UrlChecker.Console
{
    public class UrlChecker
    {
        /// <summary>
        /// Gebaseerd op https://stackoverflow.com/questions/927847/is-there-a-url-validator-on-net.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool CheckUrl(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri validatedUri)) //.NET URI validation.
            {
                //If true: validatedUri contains a valid Uri. Check for the scheme in addition.
                return (validatedUri.Scheme == Uri.UriSchemeHttp || validatedUri.Scheme == Uri.UriSchemeHttps);
            }
            return false;
        }
    }
}
