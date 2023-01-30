
using AngularJSWebUI.DataContext;
using AngularJSWebUI.DataContext.GenericRepo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private DemoContext _context;
        public UnitOfWork()
        {
            _context = new DemoContext();
        }
        public UnitOfWork(DemoContext context)
        {
            this._context = context;
        }

        public DbConnection GetDbConnection()
        {
            return _context.Database.Connection;
        }
        IGenericRepository<tbl_student> _studentRepository;
        public IGenericRepository<tbl_student> StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new GenericRepository<tbl_student>(_context);
                }
                return _studentRepository;
            }
        }
        IGenericRepository<tbl_subject> _subjectRepository;
        public IGenericRepository<tbl_subject> SubjectRepository
        {
            get
            {
                if (_subjectRepository == null)
                {
                    _subjectRepository = new GenericRepository<tbl_subject>(_context);
                }
                return _subjectRepository;
            }
        }
        IGenericRepository<tbl_city> _cityRepository;
        public IGenericRepository<tbl_city> CityRepository
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository = new GenericRepository<tbl_city>(_context);
                }
                return _cityRepository;
            }
        }
        IGenericRepository<tbl_student_subject> _studentsubjectRepository;
        public IGenericRepository<tbl_student_subject> StudentSubjectRepository
        {
            get
            {
                if (_studentsubjectRepository == null)
                {
                    _studentsubjectRepository = new GenericRepository<tbl_student_subject>(_context);
                }
                return _studentsubjectRepository;
            }
        }

        IGenericRepository<tbl_country> _countryRepository;
        public IGenericRepository<tbl_country> CountryRepository
        {
            get
            {
                if (_countryRepository == null)
                {
                    _countryRepository = new GenericRepository<tbl_country>(_context);
                }
                return _countryRepository;
            }
        }

        IGenericRepository<tbl_gender> _genderRepository;
        public IGenericRepository<tbl_gender> GenderRepository
        {
            get
            {
                if (_genderRepository == null)
                {
                    _genderRepository = new GenericRepository<tbl_gender>(_context);
                }
                return _genderRepository;
            }
        }

        IGenericRepository<tbl_state> _stateRepository;
        public IGenericRepository<tbl_state> StateRepository
        {
            get
            {
                if (_stateRepository == null)
                {
                    _stateRepository = new GenericRepository<tbl_state>(_context);
                }
                return _stateRepository;
            }
        }
    }
}