using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Exceptions;
using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class ReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IPlayerRepository _userRepository;

        public ReportService(IReportRepository reportRepository, IPlayerRepository userRepository)
        {
            _reportRepository = reportRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Create report for user by email
        /// </summary>
        /// <param name="createParams"></param>
        /// <returns></returns>
        public async Task<ReportDTO> CreateReport(ReportCreateParamsDTO createParams)
        {
            var user = await _userRepository.GetPlayerByEmail(createParams.UserEmail);
            if (user == null) throw new ReportServiceException($"User: {createParams.UserEmail} is not found.");

            var report = new Report(user.Id, createParams.Content);

            await _reportRepository.Insert(report);

            return new ReportDTO(report);
        }
    }
}
