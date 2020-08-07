using System;
using Microsoft.AspNetCore.Mvc;
using Swagger_DotNetCore_Model_Api.Models;
using Swagger_DotNetCore_Model_Api.Services;

namespace Swagger_DotNetCore_Model_Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService = new UserService();

        /// <summary>
        /// Get all users.
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var users = _userService.Select();

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// get a specific user.
        /// </summary>
        /// <param name="id">user id</param>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var user = _userService.Select(id);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="userModel">new user</param>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel userModel)
        {
            try
            {
                var user = _userService.Insert(userModel);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Update a specific user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="userModel">user model</param> 
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] UserModel userModel)
        {
            try
            {
                var user = _userService.Update(id, userModel);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deletes a specific user.
        /// </summary>
        /// <param name="id">user id</param> 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _userService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
