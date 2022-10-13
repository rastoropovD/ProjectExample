using LecturesProjectExample.Example.Core.Query;
using LecturesProjectExample.Example.Dtos;
using LecturesProjectExample.Example.Queries.GetStudentById;
using Microsoft.AspNetCore.Mvc;

namespace LecturesProjectExample.Controllers.Students
{
    public class GetStudentInfoController : Controller
    {
        private readonly IQueryHandler<GetStudentByIdQuery, StudentDto> _handler;

        public GetStudentInfoController(IQueryHandler<GetStudentByIdQuery, StudentDto> handler)
        {
            _handler = handler;
        }

        public async Task<JsonResult> Index(string id)
        {
            StudentDto dto = await _handler.Handle(new GetStudentByIdQuery(id));

            return Json(dto);
        }
    }
}
