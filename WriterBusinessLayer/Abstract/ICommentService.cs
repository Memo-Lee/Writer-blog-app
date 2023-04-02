using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;

namespace WriterBusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryUpdate(Category category);
        //void CategoryDelete(Category category);
        List<Comment> GetList(int id);
        //Category GetById(int id);
    }
}
