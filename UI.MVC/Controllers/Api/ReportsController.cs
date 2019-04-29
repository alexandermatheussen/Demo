using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace D.UI.MVC.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : Controller
    {
        private IProjectManager mgr = new ProjectManager();

        [HttpGet]
        public IActionResult Get(int ideaId)
        {
            var reports = mgr.getReports(ideaId);
            
            if (reports == null || !reports.Any())
            {
                return NoContent();
            }

            return Ok(reports);
        }
        
        [HttpPost]
        public IActionResult Post(NewReportDTO newReport)
        {
            Report createdReport = mgr.addReport(newReport.Idea, newReport.Message);

            if (createdReport == null)
            {
                return BadRequest("Something went wrong.");
            }
            
            ReportDTO responseData = new ReportDTO()
            {
                id = createdReport.id,
                dateSubmitted = createdReport.dateSubmitted,
                ideaId = createdReport.idea.ideaId,
                reportMessage = createdReport.reportMessage
            };

            return CreatedAtAction("Get", new {id = responseData.id}, responseData);
        }
    }
}