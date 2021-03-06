﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBusinessLogic.BindingModels
{
    public class CommentBindingModel
    {
        public int? Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string Author { get; set; }
        public int BlogId { get; set; }
    }
}
