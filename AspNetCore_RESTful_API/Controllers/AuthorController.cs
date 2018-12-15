using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IRepository _libraryRepository;

        public AuthorController(IRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet("api/authors")]
        public IActionResult GetAuthors()
        {
            var authors = _libraryRepository.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(string id)
        {
            var author = _libraryRepository.GetAuthor(Guid.Parse(id));
            return Ok(author);
        }
    }
}