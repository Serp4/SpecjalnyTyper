using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecjalnyTyper.Models
{
    public class SetViewModel
    {
        public Vote vote { get; set; }
        public List<Game> listGame { get; set; }
    }
}