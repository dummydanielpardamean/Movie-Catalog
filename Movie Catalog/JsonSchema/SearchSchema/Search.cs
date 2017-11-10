using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Catalog.JSONSchema.SearchSchema
{
    class Search
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<SearchResult> results { get; set; }
    }
}
