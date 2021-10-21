using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocsReader.Modal
{
    public class Documents
    {
        [Key]
        public String Id { get; set; }

        [Required]
        public String Name { get; set; }
        public String Shortname { get; set; }
        public String Format { get; set; }
        public String DefaultDocumentName { get; set; }
        public String NavigationDocumentName { get; set; }
        public String MinimumVersions { get; set; }
        public String DocumentStoreType { get; set; }
        public String ExtraProperties { get; set; }
        public String MainWebsiteUrl { get; set; }
        public String LatestVersionBranchName { get; set; }
        public String ParametersDocumentName { get; set; }
        public String ConcurrencyStamp { get; set; }


    }
}
