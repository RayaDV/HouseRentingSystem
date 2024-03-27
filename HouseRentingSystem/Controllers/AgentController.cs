using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;
        public AgentController(IAgentService agentService)
        {
            this.agentService = agentService;
        }

        [HttpGet]
        [NotAnAgent]  //not async attribute
        public IActionResult Become()  // not async becouse it does nothing synchronized
        {
            //if (await agentService.ExistsByIdAsync(User.Id()))  // it is replaced by [NotAnAgent] attribute
            //{
            //    return BadRequest();
            //}

            var model = new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        [NotAnAgent]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            if (await agentService.UserWithPhoneNumberExistsAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
            }

            if (await agentService.UserHasRentsAsync(User.Id()))
            {
                ModelState.AddModelError("Error", HasRents);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }


}
