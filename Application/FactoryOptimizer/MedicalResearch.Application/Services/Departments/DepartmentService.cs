using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Departments.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalResearch.Domain.Departments;
using System.Linq;

namespace MedicalResearch.Application.Services.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
        }

        public async Task<IList<DepartmentDTO>> GetList()
        {
            return await _departmentRepository.GetList();
        }

        public async Task<int> Create(DepartmentCreateUpdateDTO departmentDTO)
        {
            var department = new Department
            {
                CityID = departmentDTO.CityID,
                Street = departmentDTO.Street,
                Building = departmentDTO.Building,
                PhoneNumber = departmentDTO.PhoneNumber,
                WorkSchedules = departmentDTO.WorkSchedules.Select(x => new WorkSchedule
                {
                    DayOfWeekID = x.DayOfWeekId,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                }).ToList()
            };

            await _departmentRepository.Create(department);
            await _departmentRepository.SaveChanges();

            return department.ID;
        }

        public async Task<DepartmentDetailsDTO> GetDetails(int id)
        {
            return await _departmentRepository.GetDetails(id);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, DepartmentCreateUpdateDTO departmentDTO)
        {
            var item = await _departmentRepository.Get(id);
            if (item == null)
                throw new ArgumentNullException($"Department does not exist with this id ={id}");

            item.CityID = departmentDTO.CityID;
            item.Street = departmentDTO.Street;
            item.Building = departmentDTO.Building;
            item.PhoneNumber = departmentDTO.PhoneNumber;
            item.WorkSchedules.Clear();
            item.WorkSchedules = departmentDTO.WorkSchedules.Select(x => new WorkSchedule
            {
                DayOfWeekID = x.DayOfWeekId,
                StartTime = x.StartTime,
                EndTime = x.EndTime
            }).ToList();

            await _departmentRepository.SaveChanges();
        }
    }
}
