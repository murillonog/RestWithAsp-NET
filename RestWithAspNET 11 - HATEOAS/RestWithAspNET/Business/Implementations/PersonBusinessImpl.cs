﻿using System.Collections.Generic;
using RestWithAspNET.Data.Converters;
using RestWithAspNET.Data.VO;
using RestWithAspNET.Model;
using RestWithAspNET.Repository.Generic;

namespace RestWithAspNET.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }     
    }
}
