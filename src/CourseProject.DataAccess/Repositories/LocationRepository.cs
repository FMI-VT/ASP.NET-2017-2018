﻿namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    class LocationRepository : BaseRepository<Location>
    {
        public override void Save(Location location)
        {
            if (location.Id == 0)
            {
                Create(location);
            }
            else
            {
                Update(location, item => item.Id == location.Id);
            }
        }
    }
}