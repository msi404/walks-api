using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Test.Models.Domain;
using Test.Models.DTO;
using Test.Repositories;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;
        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {
            var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);
            await walkRepository.CreateAsync(walkDomainModel);
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }
    }
}