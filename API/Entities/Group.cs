using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Group
    {
        #region Properties
        [Key]
        public string Name { get; set; } // PK

        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
        #endregion

        #region CTOR
        // need this (default) for entityframework.
        public Group()
        {

        }

        public Group(string name)
        {
            Name = name;
        } 
        #endregion
    }
}
