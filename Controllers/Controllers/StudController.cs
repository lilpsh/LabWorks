using Models.Entities;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* @author - Michael Mushynskyi
*
* @date - 10/22/2019 3:53:15 AM 
*/

namespace Controllers.Controllers
{
    public class StudController : CRUDController
    {
        public StudentModel model;
        public StudController()
        {
            model = new StudentModel();
            isActive = true;
        }
        public override string CheckInput(string input, string command)
        {
            string output = "StudController\n\n";
            switch(command.ToLower())
            {
                case "get":
                    output += Get(input);
                    break;
                case "get all":
                    output += GetAll(input);
                    break;
                case "change":
                    output += Change(input);
                    break;
                case "add":
                    output += Add(input);
                    break;
                case "remove":
                    output += Remove(input);
                    break;
                case "back":
                    isActive = false;
                    break;
                case null:
                    break;
                default:
                    output += "Wrong command!";
                    break;
            }
            return output + GetCommands();
        }

        protected override string Add(string input)
        {
            string[] parameters = input.Split('|');
            Student result = model.Add(int.Parse(parameters[0]),
                                       parameters[1],
                                       int.Parse(parameters[2]));
            return "Obect was successfully created:\n"+ "+---+--------------+---+\n" +
                   string.Format(Student.OutputPattern, "Id", "Name", "Age") +
                   "+---+--------------+---+\n" +
                   result.ToString();
        }

        protected override string Change(string input)
        {
            throw new NotImplementedException();
        }

        protected override string Get(string input)
        {
            throw new NotImplementedException();
        }

        protected override string GetAll(string input)
        {
            throw new NotImplementedException();
        }

        protected override string Remove(string input)
        {
            throw new NotImplementedException();
        }
    }
}
