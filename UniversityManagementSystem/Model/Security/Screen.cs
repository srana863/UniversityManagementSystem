using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Security
{
    public class Screen
    {
        public int Id { get; set; }

        public string ScreenCode { get; set; }

        public int ScreenTypeId { get; set; }

        public string ScreenUrl { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public bool? IsOperation { get; set; }

        public bool? IsSetup { get; set; }

        public bool? IsReport { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
