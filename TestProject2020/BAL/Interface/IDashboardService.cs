using BAL.ViewModel;

namespace BAL.Interface
{
    public interface IDashboardService
    {
        long CreateDasboard(DashboardVM model);
        void DeleteDashboard(long id);
        DashboardVM GetDashboards();
        DashboardVM GetDashboard(long id);
    }
}
