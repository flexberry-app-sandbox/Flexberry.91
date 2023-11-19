import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  важност: DS.attr('string'),
  контр: DS.attr('number'),
  номЗаяв: DS.attr('string'),
  состоян: DS.attr('string'),
  текст: DS.attr('string'),
  контрагент: DS.belongsTo('i-i-s-9-контрагент', { inverse: null, async: false }),
  сотрудник: DS.belongsTo('i-i-s-9-сотрудник', { inverse: null, async: false })
});

export let ValidationRules = {
  важност: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.важност.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  контр: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.контр.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  номЗаяв: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.номЗаяв.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  состоян: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.состоян.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  текст: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.текст.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  контрагент: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.контрагент.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  сотрудник: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.сотрудник.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗаявкаE', 'i-i-s-9-заявка', {
    текст: attr('Текст', { index: 0 })
  });

  modelClass.defineProjection('ЗаявкаL', 'i-i-s-9-заявка', {
    текст: attr('Текст', { index: 0 })
  });

  modelClass.defineProjection('ЗаявкаНаРаботыE', 'i-i-s-9-заявка', {
    текст: attr('Текст', { index: 0 })
  });

  modelClass.defineProjection('ЗаявкаНаРаботыL', 'i-i-s-9-заявка', {
    текст: attr('Текст', { index: 0 })
  });
};
