using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompetenceManager : ICompetenceService
    {
        ICompetenceDal _competenceDal;
        public CompetenceManager(ICompetenceDal competenceDal)
        {
            _competenceDal = competenceDal;
        }

        public void AddCompetence(Competence competence)
        {
            _competenceDal.Add(competence);
        }

        public void DeleteCompetence(Competence competence)
        {
            _competenceDal.Delete(competence);
        }

        public List<Competence> GetAll()
        {
            return _competenceDal.GetAll();
        }

        public Competence GetById(int id)
        {
            return _competenceDal.Get(x => x.CompetenceID == id);
        }

        public void UpdateCompetence(Competence competence)
        {
            _competenceDal.Update(competence);
        }
    }
}
