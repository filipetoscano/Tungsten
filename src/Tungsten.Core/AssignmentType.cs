namespace Tungsten
{
    public enum AssignmentType
    {
        /// <summary>
        /// Assigned exclusively to a single user.
        /// </summary>
        User,

        /// <summary>
        /// Assigned to an ad-hoc group of the designated users. Any
        /// one of them can claim the task for himself.
        /// </summary>
        Users,

        /// <summary>
        /// Assigned exclusively to a single team. Any user belonging
        /// to the team may claim the task for himself.
        /// </summary>
        Team,

        /// <summary>
        /// Assigned to an ad-hoc group of the designated teams. Any
        /// user belonging to any of the teams may claim the task for
        /// himself.
        /// </summary>
        Teams,
    }
}