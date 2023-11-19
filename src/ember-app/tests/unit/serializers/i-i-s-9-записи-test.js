import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-9-записи', 'Unit | Serializer | i-i-s-9-записи', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-9-записи',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'model:i-i-s-9-должности',
    'model:i-i-s-9-записи',
    'model:i-i-s-9-заявка',
    'model:i-i-s-9-контрагент',
    'model:i-i-s-9-регистр',
    'model:i-i-s-9-сотрудник',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
