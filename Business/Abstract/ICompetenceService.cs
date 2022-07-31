using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompetenceService
    {
        List<Competence> GetAll();
        Competence GetById(int id);
        void AddCompetence(Competence competence);
        void DeleteCompetence(Competence competence);
        void UpdateCompetence(Competence competence);
    }
}
