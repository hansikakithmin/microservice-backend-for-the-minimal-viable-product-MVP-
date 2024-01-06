using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Lab.Data;
using Lab.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab : ControllerBase
    {
        private readonly ILabService _labService;

        public Lab(ILabService labService)
        {
            _labService = labService ?? throw new ArgumentNullException(nameof(labService));
        }


        /// <summary>
        /// Get all Labs
        /// </summary>
        /// <returns>return the list of Labs</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_labService.GetLabs());
        }

        /// <summary>
        /// Get Lab by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Lab  with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _labService.GetLab(id) != null ? Ok(_labService.GetLab(id)) : NoContent();
        }

        /// <summary>
        /// Add Labs
        /// </summary>
        /// <param name="lab"></param>
        /// <returns>Return the added Lab/returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Lab lab)
        {
            return Ok(_labService.AddLab(lab));
        }

        /// <summary>
        /// Update the Lab
        /// </summary>
        /// <param name="lab"></param>
        /// <returns>Return the updated lab</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Lab lab)
        {
            return Ok(_labService.UpdateLab(lab));
        }

        /// <summary>
        /// Delete the lab with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _labService.DeleteLab(id);

            return result.HasValue & result == true ? Ok($"lab with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Lab with ID:{id}.");
        }
    }
}
