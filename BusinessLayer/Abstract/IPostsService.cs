﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostsService
    {
        List<Posts> list();
        void add(Posts t);
        void delete(Posts t);
        void update(Posts t);
        Posts GetByID(int id);
        List<Posts> GetCompanyPostList(int id);
    }
}
