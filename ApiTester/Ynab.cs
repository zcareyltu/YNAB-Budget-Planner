﻿
using YnabRestApi;
using YnabRestApi.ResponseData;

namespace YNAB_Budget_Planner {

    public static class Ynab {

        private static YnabApi ynab;

        static Ynab() {
            ynab = ApiClientFactory.Create(YnabAccessToken.Token);
        }

        private static T? GetResponse<T>(Task<ApiResponse<T>> task) where T : class, new() {
            // HTTP Error codes show up during task.Wait().
            // See errors here: https://api.youneedabudget.com/#errors
            try {
                task.Wait();
                return task.Result.Data;
            }catch(Exception) {
                return null;
            }
        }

        /*public static BudgetData GetBudget(string budgetId = "last-used") {
            return GetResponse(ynab.GetBudget(budgetId));
        }*/

        /*public static async Task<string> GetBudgetName() {
            ApiResponse<BudgetsData> response = await ynab.GetBudgets();
            return response.Data.Budgets[0].Name;
        }*/

        public static CategoriesData GetCategories(string budgetId = "last-used") {
            return GetResponse(ynab.GetCategories(budgetId));
        }

    }
}
