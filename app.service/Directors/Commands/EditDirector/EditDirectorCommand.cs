using System;
using System.Collections.Generic;
using System.Text;

namespace app.service.Directors.Commands.EditDirector
{
    public class EditDirectorCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
