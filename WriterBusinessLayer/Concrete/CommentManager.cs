﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterBusinessLayer.Abstract;
using WriterDataAccess.Abstract;

namespace WriterBusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        IComment _comment;
        public CommentManager(IComment comment)
        {
            _comment = comment;
        }
        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _comment.GetListAll(x => x.BlogID == id);
        }
    }
}
