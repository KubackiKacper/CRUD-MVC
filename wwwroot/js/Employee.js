function confirmDelete(EmployeeId) {
  if (confirm('Are you sure you want to delete?')) {
    window.location.href = '/CRUD_MVC/DeleteEmployee?id=' + EmployeeId;
  }
}
