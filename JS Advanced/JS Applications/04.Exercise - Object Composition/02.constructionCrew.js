function modifyObject(object) {
    if (!object.dizziness) {
        return object;
    }

    const additionalWeight = object.weight * object.experience * 0.1;
    object.levelOfHydrated += additionalWeight;
    object.dizziness = false;

    return object;
}

console.log(modifyObject({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
));