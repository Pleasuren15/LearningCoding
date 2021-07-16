using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LearningCoding.Models.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<IdentityUser> _users;
        public IEnumerable<Book> _books;
        public IEnumerable<Feedback> _feedbacks;
        public IEnumerable<ProgrammingLanguage> _programmingLanguages;
        public PagingInfo _pagingInfoModel;
    }
}
