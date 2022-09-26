using LecturesProjectExample.Example.Commands.AddStudent;
using LecturesProjectExample.Example.Core.Command;
using Microsoft.AspNetCore.Mvc;

namespace LecturesProjectExample.Controllers.Students
{
    public class AddStudentController : Controller
    {
        // command handler dependency
        private readonly ICommandHandler<AddStudentCommand> _commandHandler;

        // injecting dependency with constructor
        public AddStudentController(ICommandHandler<AddStudentCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public async Task<IActionResult> AddStudent()
        {
            // execute command handler
            await _commandHandler.Handle(new AddStudentCommand());

            return View("../Students/Index");
        }
    }
}
