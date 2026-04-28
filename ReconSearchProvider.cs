using System;
using System.Collections.Generic;

namespace BigBountyRecon
{
    /// <summary>
    /// Provides predefined reconnaissance search queries for various sources.
    /// Maintained by VIPHACKER100
    /// </summary>
    public static class ReconSearchProvider
    {
        /// <summary>
        /// Defines all available reconnaissance search queries.
        /// Key is the button identifier, Value is the SearchQuery object.
        /// </summary>
        public static Dictionary<string, SearchQuery> GetSearchQueries()
        {
            return new Dictionary<string, SearchQuery>
            {
                // Directory and File Discovery
                { "button9", new SearchQuery("Directory Listing", "https://www.google.com/search?q=site:{0} intitle:index.of") },
                { "button1", new SearchQuery("Configuration Files", "https://www.google.com/search?q=site:{0} ext:xml | ext:conf | ext:cnf | ext:reg | ext:inf | ext:rdp | ext:cfg | ext:txt | ext:ora | ext:ini") },
                { "button2", new SearchQuery("Database Files", "https://www.google.com/search?q=site:{0} ext:sql | ext:dbf | ext:mdb") },
                { "button3", new SearchQuery("Apache Config Files", "https://www.google.com/search?q=site:{0} filetype:config \"apache\"") },

                // WordPress Discovery
                { "button6", new SearchQuery("WordPress Related", "https://www.google.com/search?q=site:{0} inurl:wp- | inurl:wp-content | inurl:plugins | inurl:uploads | inurl:themes | inurl:download") },
                { "button23", new SearchQuery("WordPress Content", "https://www.google.com/search?q=site:{0} inurl:wp-content | inurl:wp-includes") },

                // Log Files
                { "button7", new SearchQuery("Log Files", "https://www.google.com/search?q=site:{0} ext:log") },

                // Backup Files
                { "button10", new SearchQuery("Backup Files", "https://www.google.com/search?q=site:{0} ext:bkf | ext:bkp | ext:bak | ext:old | ext:backup") },

                // Login Pages
                { "button8", new SearchQuery("Login Pages", "https://www.google.com/search?q=site:{0} inurl:login | inurl:signin | intitle:Login | intitle: signin | inurl:auth") },

                // Document Files
                { "button12", new SearchQuery("Publicly Exposed Documents", "https://www.google.com/search?q=site:{0} ext:doc | ext:docx | ext:odt | ext:pdf | ext:rtf | ext:sxw | ext:psw | ext:ppt | ext:pptx | ext:pps | ext:csv") },

                // PHP Info
                { "button13", new SearchQuery("phpinfo()", "https://www.google.com/search?q=site:{0} ext:php intitle:phpinfo \"published by the PHP Group\"") },

                // Shell/Backdoor
                { "button14", new SearchQuery("Shell/Backdoor", "https://www.google.com/search?q=site:{0}  inurl:shell | inurl:backdoor | inurl:wso | inurl:cmd | shadow | passwd | boot.ini | inurl:backdoor") },

                // Readme/Config Files
                { "button15", new SearchQuery("Readme/Config Files", "https://www.google.com/search?q=site:{0}  inurl:readme | inurl:license | inurl:install | inurl:setup | inurl:config") },

                // SQL Errors
                { "button11", new SearchQuery("SQL Errors", "https://www.google.com/search?q=site:{0} intext:\"sql syntax near\" | intext:\"syntax error has occurred\" | intext:\"incorrect syntax near\" | intext:\"unexpected end of SQL command\" | intext:\"Warning: mysql_connect()\" | intext:\"Warning: mysql_query()\" | intext:\"Warning: pg_connect()\"") },

                // Redirects
                { "button16", new SearchQuery("Open Redirects", "https://www.google.com/search?q=site:{0} inurl:redir | inurl:url | inurl:redirect | inurl:return | inurl:src=http | inurl:r=http") },

                // Struts Actions
                { "button17", new SearchQuery("Struts Actions", "https://www.google.com/search?q=site:{0} ext:action | ext:struts | ext:do") },

                // Pastebin
                { "button18", new SearchQuery("Pastebin Search", "https://www.google.com/search?q=site:pastebin.com {0}") },

                // LinkedIn Employees
                { "button19", new SearchQuery("LinkedIn Employees", "https://www.google.com/search?q=site:linkedin.com employees {0}") },

                // phpinfo and .htaccess
                { "button20", new SearchQuery("phpinfo/.htaccess", "https://www.google.com/search?q=site:{0} inurl:\"/phpinfo.php\" | inurl:\".htaccess\"") },

                // Subdomains (single level)
                { "button21", new SearchQuery("Subdomains (*.domain)", "https://www.google.com/search?q=site:*.{0}") },

                // Subdomains (multi-level)
                { "button22", new SearchQuery("Subdomains (*.*.domain)", "https://www.google.com/search?q=site:*.*.{0}") },

                // Code Sharing Sites
                { "button4", new SearchQuery("Code Sharing Sites", "https://www.google.com/search?q=site%3Ahttp%3A%2F%2Fideone.com+|+site%3Ahttp%3A%2F%2Fcodebeautify.org+|+site%3Ahttp%3A%2F%2Fcodeshare.io+|+site%3Ahttp%3A%2F%2Fcodepen.io+|+site%3Ahttp%3A%2F%2Frepl.it+|+site%3Ahttp%3A%2F%2Fjustpaste.it+|+site%3Ahttp%3A%2F%2Fpastebin.com+|+site%3Ahttp%3A%2F%2Fjsfiddle.net+|+site%3Ahttp%3A%2F%2Ftrello.com+|+site%3A*.atlassian.net+|+site%3Abitbucket.org+\"{0}\"") },

                // Atlassian/Bitbucket
                { "button5", new SearchQuery("Atlassian/Bitbucket", "https://www.google.com/search?q=site%3Aatlassian.net+|+site%3Abitbucket.org+\"{0}\"") },

                // Git Repositories
                { "button44", new SearchQuery(".git Repositories", "https://www.google.com/search?q=inurl:\".git\" {0} -github ") },

                // Traefik Dashboard
                { "button45", new SearchQuery("Traefik Dashboard", "https://www.google.com/search?q=intitle:traefik+inurl:8080/dashboard\"{0}\"") },

                // Certificate Transparency (crt.sh)
                { "button46", new SearchQuery("Certificate Transparency", "https://crt.sh/?q={0}") },

                // GitHub Search
                { "button25", new SearchQuery("GitHub Search", "https://github.com/search?q=\"*.{0}\"") },

                // GitHub Gist Search
                { "button36", new SearchQuery("GitHub Gist Search", "https://gist.github.com/search?q=*.{0}") },

                // Archive.org WordPress
                { "button24", new SearchQuery("Archive.org WordPress", "http://wwwb-dedup.us.archive.org:8083/cdx/search?url={0}/&matchType=domain&collapse=digest&output=text&fl=original,timestamp&filter=urlkey:.*wp[-].*&limit=1000000&xx=") },

                // OpenBugBounty
                { "button26", new SearchQuery("OpenBugBounty", "https://www.openbugbounty.org/search/?search={0}") },

                // Reddit Search
                { "button27", new SearchQuery("Reddit Search", "https://www.reddit.com/search/?q={0}") },

                // Crossdomain.xml
                { "button28", new SearchQuery("crossdomain.xml", "https://www.google.com/search?q={0}/crossdomain.xml") },

                // robots.txt
                { "button47", new SearchQuery("robots.txt", "https://www.google.com/search?q={0}/robots.txt") },

                // Security Headers
                { "button48", new SearchQuery("Security Headers", "https://securityheaders.com/?q={0}&followRedirects=on") },

                // ThreatCrowd
                { "button29", new SearchQuery("ThreatCrowd", "https://threatcrowd.org/domain.php?domain={0}") },

                // RiskIQ
                { "button49", new SearchQuery("RiskIQ", "https://community.riskiq.com/search/{0}") },

                // SWF Files
                { "button30", new SearchQuery("SWF Files", "https://www.google.com/search?q=inurl:{0} ext:swf") },

                // YouTube Search
                { "button50", new SearchQuery("YouTube Search", "https://www.youtube.com/results?search_query={0}") },

                // Yandex SWF Search
                { "button31", new SearchQuery("Yandex SWF Files", "https://yandex.com/search/?text=site:{0}  mime:swf") },

                // Archive.org SWF (CDX)
                { "button32", new SearchQuery("Archive.org SWF (CDX)", "https://web.archive.org/cdx/search?url={0}/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=urlkey:.*swf&limit=100000") },

                // Archive.org Flash (MIME)
                { "button35", new SearchQuery("Archive.org Flash (MIME)", "https://web.archive.org/cdx/search?url={0}/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=mimetype:application/x-shockwave-flash&limit=100000") },

                // Archive.org Full History
                { "button34", new SearchQuery("Archive.org Full History", "https://web.archive.org/web/*/{0}/*") },

                // Reverse IP Lookup
                { "button33", new SearchQuery("Reverse IP Lookup", "https://viewdns.info/reverseip/?host={0}&t=1") },

                // PublicWWW
                { "button43", new SearchQuery("PublicWWW", "https://publicwww.com/websites/\"{0}\"") },

                // Censys IPv4
                { "button42", new SearchQuery("Censys IPv4", "https://censys.io/ipv4?q={0}") },

                // Censys Domains
                { "button41", new SearchQuery("Censys Domains", "https://censys.io/domain?q={0}") },

                // Censys Certificates
                { "button40", new SearchQuery("Censys Certificates", "https://censys.io/certificates?q={0}") },

                // Shodan
                { "button39", new SearchQuery("Shodan", "https://www.shodan.io/search?query={0}") },

                // Google Custom Search Engine
                { "button51", new SearchQuery("Google Custom Search", "https://cse.google.com/cse?cx=002972716746423218710:veac6ui3rio#gsc.tab=0&gsc.q={0}") },

                // Throwbin
                { "button52", new SearchQuery("Throwbin", "https://www.google.com/search?q=site:throwbin.io {0}") },

                // DomainEye
                { "button53", new SearchQuery("DomainEye", "https://domaineye.com/similar/{0}") },

                // GitLab
                { "button54", new SearchQuery("GitLab", "https://www.google.com/search?q=inurl:gitlab {0}") },

                // StackOverflow
                { "button55", new SearchQuery("StackOverflow", "https://www.google.com/search?q=site:stackoverflow.com \"{0}\"") },

                // AWS S3
                { "button57", new SearchQuery("AWS S3 Buckets", "https://www.google.com/search?q=site:.s3.amazonaws.com \"{0}\"") },

                // DigitalOcean Spaces
                { "button56", new SearchQuery("DigitalOcean Spaces", "https://www.google.com/search?q=site:digitaloceanspaces.com \"{0}\"") },

                // WhatCMS
                { "button58", new SearchQuery("WhatCMS", "https://whatcms.org/?s={0}") },

                // SharePoint
                { "button37", new SearchQuery("SharePoint", "https://www.google.com/search?q=.sharepoint.com/_vti_bin/webpartpages/asmx -docs -msdn -mdsec site:{0}") },

                // WSDL Files
                { "button38", new SearchQuery("WSDL Files", "https://www.google.com/search?q=site:{0} filetype:wsdl | filetype:WSDL | ext:svc | inurl:wsdl | Filetype: ?wsdl | inurl:asmx?wsdl | inurl:jws?wsdl | intitle:_vti_bin/sites.asmx?wsdl | inurl:_vti_bin/sites.asmx?wsdl") }
            };
        }
    }

    /// <summary>
    /// Represents a reconnaissance search query.
    /// </summary>
    public class SearchQuery
    {
        /// <summary>
        /// Gets the name of the search query.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the URL template for the search query (with {0} as placeholder for domain).
        /// </summary>
        public string UrlTemplate { get; set; }

        /// <summary>
        /// Initializes a new instance of the SearchQuery class.
        /// </summary>
        /// <param name="name">The name of the search query</param>
        /// <param name="urlTemplate">The URL template with {0} as placeholder</param>
        public SearchQuery(string name, string urlTemplate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UrlTemplate = urlTemplate ?? throw new ArgumentNullException(nameof(urlTemplate));
        }
    }
}
