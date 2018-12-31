

//View Model is not declared in javascript anymore.  It is delcared in the backend, and the Person Json object can be submitted with an Ajax call to the backend. If modify data, then do it in backend code

var mainVue = new Vue(
    {
        el: '#vueapp',

        components: ['comp1'],

        data: viewModelData,

//{
//            person: {
//                firstName: 'First Name',
//                lastName: 'Last Name',
//            }
//        },


    });

