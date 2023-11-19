import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  кодРегист: DS.attr('number'),
  наимен: DS.attr('string'),
  период: DS.attr('string'),
  регистрат: DS.attr('string')
});

export let ValidationRules = {
  кодРегист: {
    descriptionKey: 'models.i-i-s-9-регистр.validations.кодРегист.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  наимен: {
    descriptionKey: 'models.i-i-s-9-регистр.validations.наимен.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  период: {
    descriptionKey: 'models.i-i-s-9-регистр.validations.период.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  регистрат: {
    descriptionKey: 'models.i-i-s-9-регистр.validations.регистрат.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('РегистрE', 'i-i-s-9-регистр', {
    регистрат: attr('Регистрат', { index: 0 }),
    период: attr('Период', { index: 1 })
  });

  modelClass.defineProjection('РегистрL', 'i-i-s-9-регистр', {
    регистрат: attr('Регистрат', { index: 0 }),
    период: attr('Период', { index: 1 })
  });
};
