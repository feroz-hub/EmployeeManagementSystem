// Open modals for each action
function openAddQualificationModal(employeeId) {
    loadModal(`/Qualifications/Create?employeeId=${employeeId}`);
}

function openUpdateQualificationModal(employeeId, qualificationId) {
    loadModal(`/Qualifications/Edit/${qualificationId}?employeeId=${employeeId}`);
}

function openDeleteQualificationModal(employeeId, qualificationId) {
    loadModal(`/Qualifications/Delete/${qualificationId}?employeeId=${employeeId}`);
}

function openAddExperienceModal(employeeId) {
    loadModal(`/Experiences/Create?employeeId=${employeeId}`);
}

function openUpdateExperienceModal(employeeId, experienceId) {
    loadModal(`/Experiences/Edit/${experienceId}?employeeId=${employeeId}`);
}

function openDeleteExperienceModal(employeeId, experienceId) {
    loadModal(`/Experiences/Delete/${experienceId}?employeeId=${employeeId}`);
}

function openAddGovernmentDocumentModal(employeeId) {
    loadModal(`/GovernmentDocuments/Create?employeeId=${employeeId}`);
}

function openUpdateGovernmentDocumentModal(employeeId, documentId) {
    loadModal(`/GovernmentDocuments/Edit/${documentId}?employeeId=${employeeId}`);
}

function openDeleteGovernmentDocumentModal(employeeId, documentId) {
    loadModal(`/GovernmentDocuments/Delete/${documentId}?employeeId=${employeeId}`);
}

function openAddCertificationModal(employeeId) {
    loadModal(`/Certification/Create?employeeId=${employeeId}`);
}

function openUpdateCertificationModal(employeeId, certificationId) {
    loadModal(`/Certification/Edit/${certificationId}?employeeId=${employeeId}`);
}

function openDeleteCertificationModal(employeeId, certificationId) {
    loadModal(`/Certification/Delete/${certificationId}?employeeId=${employeeId}`);
}

function openUpdatePersonalDetailsModal(employeeId) {
    loadModal(`/PersonalDetails/Edit?employeeId=${employeeId}`);
}

function openApplyLeaveModal(employeeId){
    loadModal(`/Leave/ApplyLeave?employeeId=${employeeId}`)
}
function openCancelLeaveModal(employeeId,id){
    loadModal(`/Leave/CancelLeave/${id}?employeeId=${employeeId}`)
}


// Load modal content via AJAX
function loadModal(url) {
    $.get(url, function (data) {
        $('#modalContainer').html(data);
        $('#modalContainer').find('.modal').modal('show');
    });
}