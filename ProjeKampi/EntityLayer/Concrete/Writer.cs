﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        //Yazar sınıfı
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurName { get; set; }
        [StringLength(300)]
        public string WriterImage { get; set; }
        [StringLength(100)]        
        public string WriterAbout { get; set; }
        [StringLength(100)]
        public string WriterMail { get; set; }
        [StringLength(100)]
        public string WriterPassWord { get; set; }
        [StringLength(50)]
        public string WriterTitle { get; set; }
        public bool WriterSatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
