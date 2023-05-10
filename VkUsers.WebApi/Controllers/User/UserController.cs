using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using VkUsers.Application.Groups.Queries.GetGroupList;
using VkUsers.Application.Users.Commands.CreateUser;
using VkUsers.Application.Users.Commands.DeleteUser;
using VkUsers.Application.Users.Queries.GetUserDetails;
using VkUsers.Application.Users.Queries.GetUserList;

namespace VkUsers.WebApi.Controllers.User
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UserController : Controller
    {
        private IMediator mediator;
        protected IMediator Mediator => mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        private readonly IMapper mapper;

        public UserController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<GetListVm>> GetAll()
        {
            var query = new GetUserListQuery();
            var vm = await Mediator.Send(query);
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult<UserDetailsDto>> Get(Guid id)
        {
            var query = new GetUserDetailsQuery { Id = id };
            var vm = await Mediator.Send(query);
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult> Delete(Guid id)
        {
            var query = new DeleteUserCommand { Id = id };
            await Mediator.Send(query);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var query = new GetGroupQuery();
            var result = await Mediator.Send(query);
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(GetListVm vm)
        {
           vm.CreateUser.Id = Guid.NewGuid();
            vm.CreateUser.created_date = DateTime.Now; //.SpecifyKind(vm.CreateUser.created_date, DateTimeKind.Utc);
            var request = mapper.Map<CreateUserCommand>(vm.CreateUser);
            //Task.Delay(500);
            Mediator.Send(request);
            return RedirectToAction("GetAll");
        }

    }
}
