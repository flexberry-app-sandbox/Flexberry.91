import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  имя: DS.attr('string'),
  кодДолж: DS.attr('number'),
  номПасп: DS.attr('number'),
  отчест: DS.attr('string'),
  серия: DS.attr('number'),
  табНом: DS.attr('string'),
  фамил: DS.attr('string'),
  должности: DS.belongsTo('i-i-s-9-должности', { inverse: null, async: false })
});

export let ValidationRules = {
  имя: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.имя.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  кодДолж: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.кодДолж.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  номПасп: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.номПасп.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  отчест: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.отчест.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  серия: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.серия.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  табНом: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.табНом.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  фамил: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.фамил.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  должности: {
    descriptionKey: 'models.i-i-s-9-сотрудник.validations.должности.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СотрудникE', 'i-i-s-9-сотрудник', {
    кодДолж: attr('Код долж', { index: 0 }),
    имя: attr('Имя', { index: 1 }),
    должности: belongsTo('i-i-s-9-должности', 'Должности', {

    }, { index: 2 })
  });

  modelClass.defineProjection('СотрудникL', 'i-i-s-9-сотрудник', {
    имя: attr('Имя', { index: 0 }),
    должности: belongsTo('i-i-s-9-должности', 'Должности', {
      наимен: attr('', { index: 2 }),
      кодДолж: attr('', { index: 3 })
    }, { index: 1 }),
    фамил: attr('', { index: 4 }),
    серия: attr('', { index: 5 }),
    отчест: attr('', { index: 6 }),
    номПасп: attr('', { index: 7 })
  });
};
