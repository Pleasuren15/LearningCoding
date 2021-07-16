using System.Collections.Generic;

namespace LearningCoding.Models.ViewModels
{
    public class BooksViewModel
    {
        public IEnumerable<Book> _books;
        public PagingInfo _pagingInfoModel;
    }
}
