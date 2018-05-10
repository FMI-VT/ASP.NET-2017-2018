namespace CourseProject.DataAccess.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;

    internal class CustomSqlServerMigrationSqlGenerator : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(AddColumnOperation addColumnOperation)
        {
            SetAutoColumn(addColumnOperation.Column);
            base.Generate(addColumnOperation);
        }

        protected override void Generate(CreateTableOperation createTableOperation)
        {
            SetAutoColumn(createTableOperation.Columns);
            base.Generate(createTableOperation);
        }

        protected static void SetAutoColumn(IEnumerable<ColumnModel> columns)
        {
            foreach (var columnModel in columns)
            {
                SetAutoColumn(columnModel);
            }
        }

        protected static void SetAutoColumn(PropertyModel column)
        {
            switch (column.Name)
            {
                case "CreatedTime":
                case "UpdatedTime":
                    column.DefaultValueSql = "GETUTCDATE()";
                    break;
            }
        }
    }
}