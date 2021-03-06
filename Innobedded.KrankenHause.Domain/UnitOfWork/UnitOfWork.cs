using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innobedded.KrankenHause.Data.Context;

using Innobedded.KrankenHause.Domain.Repositories;
using Innobedded.KrankenHause.Domain.Services;


namespace Innobedded.KrankenHause.Domain.UnitOfWork
{
    /// <summary>
    /// Notice | Achtung :-)
    /// This Class can not Inherit Or Changed 
    /// </summary>
    public sealed class UnitOfWork : IDisposable
    {
        private KrankenHausDbContext _maindbcontext;

        public UnitOfWork()
        {
            _maindbcontext = new KrankenHausDbContext();
        }

        private FachRepository fachRepository;
        private DoctorRepository doctorRepository;
        private KlinikServicesRepository servicesRepository;

        private EducationRepository educationRepository;
        private UserRepository userRepository;
        private SexRepository sexRepository;
        private InsurenceRepository insurenceRepository;
        private JobRepository jobRepository;
        private KlinikRepository klinikRepository;
        private KlinikTypeRepository klinikTypeRepository;
        private KrankRepository krankRepository;
        private ReceptionRepository receptionRepository;
        private KlinikServicesReceptionRepository klinikServicesReceptionRepository;
        private AppointmentRepository appointmentRepository;


        public AppointmentRepository AppointmentRepository
        {
            get
            {
                if (appointmentRepository == null)
                {

                    appointmentRepository = new AppointmentRepository(_maindbcontext);
                }
                return appointmentRepository;

            }
        }

        public KlinikServicesReceptionRepository KlinikServicesReceptionRepository
        {
            get
            {

                if (klinikServicesReceptionRepository == null)
                {
                    klinikServicesReceptionRepository = new KlinikServicesReceptionRepository(_maindbcontext);
                }

                return klinikServicesReceptionRepository;
            }
        }

        public ReceptionRepository ReceptionRepository
        {
            get
            {


                if (receptionRepository == null)
                {

                    receptionRepository = new ReceptionRepository(_maindbcontext);
                }
                return receptionRepository;

            }
        }

        public KrankRepository KrankRepository
        {
            get
            {


                if (krankRepository == null)
                {
                    krankRepository = new KrankRepository(_maindbcontext);
                }

                return krankRepository;
            }
        }


        public KlinikTypeRepository KlinikTypeRepository
        {
            get
            {

                if (klinikTypeRepository == null)
                {
                    klinikTypeRepository = new KlinikTypeRepository(_maindbcontext);
                }
                return klinikTypeRepository;
            }
        }


        public KlinikRepository KlinikRepository
        {
            get
            {
                if (klinikRepository == null)
                {
                    klinikRepository = new KlinikRepository(_maindbcontext);
                }
                return klinikRepository;

            }
        }

        public JobRepository JobRepository
        {
            get
            {

                if (jobRepository == null)
                {
                    jobRepository = new JobRepository(_maindbcontext);
                }
                return jobRepository;
            }
        }
        public InsurenceRepository InsurenceRepository
        {
            get
            {

                if (insurenceRepository == null)
                {
                    insurenceRepository = new InsurenceRepository(_maindbcontext);
                }
                return insurenceRepository;
            }
        }
        public FachRepository FachRepository
        {
            get
            {
                if (fachRepository == null)
                {
                    fachRepository = new FachRepository(_maindbcontext);
                }
                return fachRepository;


            }

        }

        public EducationRepository EducationRepository
        {
            get
            {

                if (educationRepository == null)
                {
                    educationRepository = new EducationRepository(_maindbcontext);
                }

                return educationRepository;
            }
        }

        public SexRepository SexRepository
        {
            get
            {

                if (sexRepository == null)
                {
                    sexRepository = new SexRepository(_maindbcontext);
                }
                return sexRepository;
            }
        }


        public DoctorRepository DoctorRepository
        {
            get
            {
                if (doctorRepository == null)
                {
                    doctorRepository = new DoctorRepository(_maindbcontext);
                }
                return doctorRepository;
            }
        }

        public KlinikServicesRepository klinikServicesRepository
        {
            get
            {
                if (servicesRepository == null)
                {
                    servicesRepository = new KlinikServicesRepository(_maindbcontext);
                }
                return servicesRepository;
            }
        }


        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_maindbcontext);
                }
                return userRepository;
            }
        }




        public int Commit()
        {
            return _maindbcontext.SaveChanges();
        }
        public void Dispose()
        {
            _maindbcontext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
