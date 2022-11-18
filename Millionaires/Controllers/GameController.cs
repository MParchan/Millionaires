using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Millionaires.DAL;
using Millionaires.DAL.Interfaces;
using Millionaires.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Millionaires.Controllers
{
    public class GameController : Controller
    {
        private readonly IService _service;

        public GameController(IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View() ;
        }

        [HttpPost]
        public IActionResult Index(string? correctAnswer, string? answer, string? takeMoney, List<Question> questions, int levelId = 0)
        {
            if(takeMoney != null)
            {
                ViewBag.Prize = takeMoney;
                return View("TookMoney");
            }
            levelId++;
            if(levelId> _service.Levels.GetAll().Count())
            {
                return View("WinGame");
            }
            var level = _service.Levels.GetById(levelId);
            if (level == null)
            {
                return NotFound();
            }

            ViewBag.levelRewards = _service.Levels.GetAll().Reverse();
            ViewBag.Prize = level.Prize;

            if(levelId>1)
            {
                ViewBag.PrizeCurrent = _service.Levels.GetById(levelId - 1).Prize;
            }
            else
            {
                ViewBag.PrizeCurrent = 0;
            }
            var question = _service.Questions.GetRandom(_service.Questions.Find(q => q.DifficultyLevel == level.DifficultyLevel));
            var count = _service.Questions.Find(q => q.DifficultyLevel == level.DifficultyLevel).Count();
            List<int> questionId = new();

            for (int i=0; i<questions.Count;i++)
            {
                if(questions[i].DifficultyLevel == level.DifficultyLevel)
                {
                    questionId.Add(questions[i].QuestionId);
                }
            }
            if (questionId.Count < count)
            {
                while (questionId.Contains(question.QuestionId))
                {
                    question = _service.Questions.GetRandom(_service.Questions.Find(q => q.DifficultyLevel == level.DifficultyLevel));
                }
            }
            questions.Add(question);

            if (correctAnswer != null && answer != null)
            {
                if (string.Equals(correctAnswer, answer[0].ToString()))
                {
                    if (question == null)
                    {
                        return NotFound();
                    }
                    return View(questions);
                }
                while(levelId-2>0)
                {
                    Level l= _service.Levels.GetById(levelId-2);
                    if (l != null)
                    {
                        if(l.Guaranteed == true)
                        {
                            ViewBag.Guaranteed = l.Prize.ToString();
                            break;
                        }
                    }
                    levelId--;
                }
                return View("LostGame");
            }
            return View(questions);
        }

        public IActionResult HowToPlay()
        {
            return View();
        }

    }
}
