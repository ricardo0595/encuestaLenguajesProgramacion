


const countrySelect = document.getElementById("country")
const programmingLanguages1 = document.getElementById("programmingLanguages1")
const programmingLanguages2 = document.getElementById("programmingLanguages2")
const itRoles = document.getElementById("itRoles")

for (const country of Lists.Countries) {
            
    const op = document.createElement('option')
    op.value = country.code
    op.innerHTML = country.name
    countrySelect.add(op)
}

for (const country of Lists.ProgrammingLanguages) {
            
    let op = document.createElement('option')
    op.value = country
    op.innerHTML = country
    let op2 = document.createElement('option')
    op2.value = country
    op2.innerHTML = country
    programmingLanguages1.add(op);
    programmingLanguages2.add(op2);
}