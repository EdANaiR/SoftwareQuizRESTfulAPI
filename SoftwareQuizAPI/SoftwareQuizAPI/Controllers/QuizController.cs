using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareQuizAPI.Data;
using SoftwareQuizAPI.Models;

namespace SoftwareQuizAPI.Controllers
{
    [Route("api/QuizController")]
    [ApiController]
    public class QuizController : ControllerBase
    {


        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }


        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion(Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuestion), new { id = question.Id }, question);
        }
    }
}