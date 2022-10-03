using LecturesProjectExample.Example.Commands.AddStudent;
using LecturesProjectExample.Example.Core.Command;
using LecturesProjectExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace LecturesProjectExample.Controllers.Students
{
    public class AddNewStudentController : Controller
    {
        // command handler dependency
        private readonly ICommandHandler<AddStudentCommand> _commandHandler;

        // injecting dependency with constructor
        public AddNewStudentController(ICommandHandler<AddStudentCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet("/Insert")]
        public IActionResult AddStudent()
        {
            return View("../Students/Index", new StudentItemViewModel());
        }

        [HttpPost("/AddStudent")]
        public async Task<IActionResult> AddStudent(StudentItemViewModel model)
        {
            // execute command handler

            await _commandHandler.Handle(new AddStudentCommand(
                Guid.NewGuid().ToString(),
                model.FirstName,
                model.LastName,
                model.YearOfStudying,
                model.Gender
                )
            );

            return RedirectToAction("Index", "Home");
        }
    }
}
