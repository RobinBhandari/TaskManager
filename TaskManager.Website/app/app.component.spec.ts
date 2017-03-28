import { AppComponent } from './app.component'

describe('AppComponent', function () {

    var sut: AppComponent;

    beforeEach(() => {
        sut = new AppComponent();
    });


    it('should create', () => {
        expect(sut instanceof AppComponent).toBe(true, 'should create AppComponent');

    });



});