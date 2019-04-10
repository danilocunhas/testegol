using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teste.GOL.Domain.Entities
{
    public class AirPlane
    {

        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Model { get; set; }
        public int NumberOfPassengers { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
