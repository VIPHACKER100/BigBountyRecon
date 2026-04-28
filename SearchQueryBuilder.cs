using System;
using System.Web;

namespace BigBountyRecon
{
    /// <summary>
    /// Utility class for building and executing reconnaissance search queries.
    /// Developed by VIPHACKER100
    /// </summary>
    public static class SearchQueryBuilder
    {
        /// <summary>
        /// Builds a search URL from a template and target domain.
        /// </summary>
        /// <param name="urlTemplate">The URL template with {0} as placeholder</param>
        /// <param name="targetDomain">The target domain to search for</param>
        /// <returns>The complete search URL</returns>
        public static string BuildSearchUrl(string urlTemplate, string targetDomain)
        {
            if (string.IsNullOrWhiteSpace(urlTemplate))
                throw new ArgumentNullException(nameof(urlTemplate));

            if (string.IsNullOrWhiteSpace(targetDomain))
                throw new ArgumentNullException(nameof(targetDomain));

            string encodedDomain = HttpUtility.UrlEncode(targetDomain);
            return string.Format(urlTemplate, encodedDomain);
        }

        /// <summary>
        /// Executes a search query by opening the URL in the default browser.
        /// </summary>
        /// <param name="searchUrl">The complete search URL to open</param>
        /// <returns>True if successful, false otherwise</returns>
        public static bool ExecuteSearch(string searchUrl)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchUrl))
                    return false;

                System.Diagnostics.Process.Start(searchUrl);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error opening search: {ex.Message}",
                    "Search Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Builds and executes a search query in one operation.
        /// </summary>
        /// <param name="urlTemplate">The URL template</param>
        /// <param name="targetDomain">The target domain</param>
        /// <returns>True if successful, false otherwise</returns>
        public static bool BuildAndExecuteSearch(string urlTemplate, string targetDomain)
        {
            try
            {
                string searchUrl = BuildSearchUrl(urlTemplate, targetDomain);
                return ExecuteSearch(searchUrl);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error executing search: {ex.Message}",
                    "Execution Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
