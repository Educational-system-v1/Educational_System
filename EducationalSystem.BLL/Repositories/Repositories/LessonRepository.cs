﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalSystem.BLL.Repositories.Interfaces;
using EducationalSystem.DAL.Models;
using EducationalSystem.DAL.Models.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EducationalSystem.BLL.Repositories.Repositories
{
    public class LessonRepository : GenericReposiory<Lessons>, ILessonRepository
    {
        private readonly Education_System _dbContext;
        public LessonRepository(Education_System dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<List<Comments>> GetAllCommentsByLessonId(int lessonId)
        {
            var comments = await _dbContext.Comments
                .Where(li => li.LessonID == lessonId)
                .ToListAsync();

            return comments;
        }

        public async Task<List<Lessons>> GetLessonsByCrsIdAsync(int crsId)
        {
            
            var lessons = await _dbContext.Lessons
                .Where(l => l.CourseID == crsId)
                .ToListAsync();
           
            return lessons;
        }
    }
}
