﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace mashovFinal.Models
{
    public class Groups
    {
        Users mentor;
        int numGroup;
        string nameGroup;
        string nameProject;
        string nameOrganization;
        string projectType;
        double finalScore;
        List<Students> listStudent;
        string link;
        string beforeLastProg;
        string beforeLastOrg;

        public Users Mentor { get => mentor; set => mentor = value; }
        public int NumGroup { get => numGroup; set => numGroup = value; }
        public string NameGroup { get => nameGroup; set => nameGroup = value; }
        public string NameProject { get => nameProject; set => nameProject = value; }
        public string NameOrganization { get => nameOrganization; set => nameOrganization = value; }
        public string ProjectType { get => projectType; set => projectType = value; }
        public double FinalScore { get => finalScore; set => finalScore = value; }
        public List<Students> ListStudent { get => listStudent; set => listStudent = value; }
        public string Link { get => link; set => link = value; }
        public string BeforeLastProg { get => beforeLastProg; set => beforeLastProg = value; }
        public string BeforeLastOrg { get => beforeLastOrg; set => beforeLastOrg = value; }

        public Groups() { }
        public Groups(Users mentr,int g, string group,string project , string organization ,string orgType ,double fscore,List<Students> ls,string listp,string b ,string before)
        {
            mentor = mentr;
            numGroup = g;
            nameGroup = group;
            nameProject = project;
            nameOrganization = organization;
            projectType = orgType;
            finalScore = fscore;
            listStudent = ls;
            link = listp;
            beforeLastProg = b;
            beforeLastOrg = before;
        }
        public List<Group_Meeting> getAllgroups(int name)
        {
            DBservices dbs = new DBservices();
            return dbs.getGroup(name);
        }
        public int putlink(string link,int id)
        {
           
            DBservices dbs = new DBservices();
            return dbs.savelink(link, id);
        }

    }
}