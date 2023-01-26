import { faker } from '@faker-js/faker';

// Defines the "Entry" class, so that we can easily couple the data together
export class Entry {
	ftzNumber: string;
	altName: string;
	description: string;
	section: string;
	sectionName: string;
	placementNotes: string;
	amount: number;
	picture: string;

	// The constructor will generate random values if no parameters are given.
	constructor() {
		this.ftzNumber = faker.random.alpha(1) + faker.random.numeric(3);
		this.altName = faker.commerce.productAdjective() + faker.commerce.product();
		this.description = faker.commerce.productName();
		this.section = faker.random.alphaNumeric(2);
		this.sectionName = faker.random.words(2);
		this.placementNotes = faker.lorem.words(4);
		this.amount = Math.floor(Math.random() * 500);
		this.picture = faker.image.nature(420, 420, true);
	}
}
